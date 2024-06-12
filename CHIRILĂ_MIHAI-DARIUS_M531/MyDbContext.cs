using CHIRILĂ_MIHAI_DARIUS_M531.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CHIRILĂ_MIHAI_DARIUS_M531
{
    public class MyDbContext : DbContext
    {
        private readonly string _windowsconnectionstring = @"data source=desktop-rpa5ssf;database=tapproject;integrated security=true;connect timeout=30;encrypt=true;trust server certificate=true;application intent=readwrite;multi subnet failover=false";



        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(_windowsconnectionstring);
        }

        protected override void onmodelcreating(ModelBuilder builder)
        {
        }
    }
}