using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    public class Shop
    {
        public Shop()
        {
            Users = new List<Users>(); 
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SeoName { get; set; }
        public virtual List<Users> Users { get; set; }

        public override string ToString()
        {
            return $"Shop: Title = {Title}; Description = {Description}; SeoName = {SeoName}";
        }
    }
}