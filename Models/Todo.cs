
using System;

namespace Api_Teste0001.Models
{
    public class Todo{
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }   
}