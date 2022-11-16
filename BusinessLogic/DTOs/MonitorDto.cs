using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class MonitorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ScreenSize { get; set; }
        public string Display { get; set; }
        public int Refresh { get; set; }
        public double Price { get; set; }
        public string ImgLink { get; set; }

        public int MatrixId { get; set; }
        public string? MatrixName { get; set; }
    }
}
