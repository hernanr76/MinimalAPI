using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using MinimalApiHR.Models;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<NuevaAxtonDBContext>();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme 
    { 
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization", 
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement 
    {
        { 
            new OpenApiSecurityScheme 
            { 
                Reference = new OpenApiReference { 
                    Id = "Bearer", 
                    Type = ReferenceType.SecurityScheme
                }
            },
            new List<string>()
        }
    });
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => 
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateActor = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.UseAuthentication();

app.MapGet("/", () => "Hello World!");
app.MapGet("/empresas", 
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    async (NuevaAxtonDBContext context) => 
        await context.Empresas.ToListAsync()
);

app.MapGet("/empresas/{empNro}",
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    async (int empNro, NuevaAxtonDBContext context, HttpContext http) =>
{
    var empresa = await context.Empresas.FindAsync(empNro);
    var identity = http.User.Identity as ClaimsIdentity;
    var userData = identity != null ? identity.Claims.FirstOrDefault(c => c.Type.Contains("userdata")) :  new Claim(ClaimTypes.UserData,"");

    Console.WriteLine(userData.Value);

    return empresa != null ? Results.Ok(empresa) : Results.NotFound();
});

app.MapGet("/personas", async (NuevaAxtonDBContext context) =>
        await context.Personas.ToListAsync()
);

app.MapGet("/personas/find/{apeOnombre}", (string apeOnombre, NuevaAxtonDBContext context) =>
{
    var p = context.Personas.Where( p => p.PerApellido.Contains(apeOnombre) || p.PerNombres.Contains(apeOnombre));
    return p != null ? Results.Ok(p ) : Results.NotFound();
});

app.MapPost("/login", (UserLogin user, NuevaAxtonDBContext context) =>
{
    var tokenString = String.Empty;

    if (!string.IsNullOrEmpty(user.UserName) && !string.IsNullOrEmpty(user.Password)) {
        var p = context.Personas.FirstOrDefault(p => !string.IsNullOrEmpty(p.PerUserName) && !string.IsNullOrEmpty(p.PerPassword) && p.PerUserName == user.UserName && p.PerPassword == user.Password);

        if (p != null)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, p.PerUserName ?? ""),
            new Claim(ClaimTypes.Email,p.PerCuil ?? ""),
            new Claim(ClaimTypes.GivenName,p.PerNombres ?? ""),
            new Claim(ClaimTypes.Surname,p.PerApellido ?? ""),
            new Claim(ClaimTypes.Role,p.PerApeCasada ?? ""),
            new Claim(ClaimTypes.UserData, "Data Source=192.168.200.17;Database=NuevaAxtonDB;User ID=axton;Password=*$8893;"),
            new Claim(ClaimTypes.StateOrProvince, (p.MiembroEmpresas.FirstOrDefault() ?? new MiembroEmpresa()).EmpNro.ToString())
        };

            var token = new JwtSecurityToken
            (
                issuer: builder.Configuration["Jwt:Issuer"],
                audience: builder.Configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(60),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
                    SecurityAlgorithms.HmacSha256)
            );

            tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

    return !String.IsNullOrEmpty(tokenString) ? Results.Ok(tokenString) : Results.Unauthorized();

});


app.Run();
