using Microsoft.EntityFrameworkCore.ChangeTracking;
using Trust_Indicator.Dtos;
using Trust_Indicator.Model;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Trust_Indicator.Data
{
    public class Repo : IRepo
    {
        private readonly MyDbContext _dbContext;

        public Repo(MyDbContext dBContext)
        {
            _dbContext = dBContext;
        }
    }
}
