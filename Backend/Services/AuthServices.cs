using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NauticalNest.Server.Models;

namespace NauticalNest.Server.Services
{
    public class AuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(storedHash);
            }
        }   

        public void RegisterUser(string username, string password)
        {
            //TODO check if user exists and to add a new user
             
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            //TODO save the user to the database with the hashed password
        }
            
        public User LoginUser(string username, string password)
        {
            //TODO retrieve user from the database

            // Verify the password
            if (user != null && VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                // Return user if authentication is successful
                return user;
            }

            // Return null or handle failed authentication
            return null;
        }
    }
}
