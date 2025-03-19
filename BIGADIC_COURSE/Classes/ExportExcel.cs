using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIGADIC_COURSE.Classes
{
    public class ExportExcel
    {
        private string _excelPath = null!;
        private string _excelName = null!;
        private int row = 6;

        public ExportExcel(string excelPath, string excelName)
        {
            _excelPath = excelPath;

            if (!Directory.Exists(_excelPath))
                Directory.CreateDirectory(_excelPath);
            _excelName = excelName;

            _excelPath += "\\" + _excelName;
        }

        // excel dosyasını oluşturmayı yaz
    }
}
