using OSGeo.GDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLayerConversion
{
    /// <summary>
    /// ГЛАВНЫЙ КЛАСС
    /// </summary>
    class Converter
    {
        /// <summary>
        /// Главный метод программы, который конвертирует векторный слой из одного формата в другой (SHP, TAB, Mid/Mif в форматы GeoJson, GML).
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile">Путь к выходному файлу с заданным форматом</param>
        /// <param name="format">Формат GeoJson или GML</param>
        public void ConvertFileFormat(string inputFile, string outputFile, string format)
        {

            Gdal.AllRegister();

            if (!File.Exists(inputFile))
            {
                throw new FileNotFoundException("Can't find the input file",
                    new Exception("Working with " + inputFile));
            }

            using (var ds = Gdal.OpenEx(inputFile, 4, null, null, null))
            {
                if (ds == null) throw new Exception("Can't open GDAL dataset: " + inputFile);

                var gdalOptions = new GDALVectorTranslateOptions(new[]{
                    "-f", format,
                    "-lco", "RFC7946=YES"  //понятия не имею, что это означает
                });
                using (var newDs = Gdal.wrapper_GDALVectorTranslateDestName(outputFile, ds, gdalOptions, null, null))
                {
                    if (newDs == null) throw new Exception("VectorTranslate failed: " + Gdal.GetLastErrorMsg());
                }
            }
        }

        
    }
}
