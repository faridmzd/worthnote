    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorthNote.Back_End.Models
{
    public class Note
    {
        public int Id { get; } = new Random().Next(10000,99999);
        public string Title { get; set; } = "Unnamed";
        public string Description { get; set; } = string.Empty; 
        public DateTime AddedTime { get; }  = DateTime.Now;


        
    }
}
