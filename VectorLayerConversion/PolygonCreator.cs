using OSGeo.GDAL;
using OSGeo.OGR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLayerConversion
{
    /// <summary>
    /// Класс, в котором должен создаваться полигон изображения (Но он не работает)
    /// </summary>
    class PolygonCreator
    {

        public void Polygonize(string fileImage)
        {
            Gdal.AllRegister();
            Ogr.RegisterAll();
            Dataset ds = Gdal.Open(fileImage, Access.GA_ReadOnly);


            Band srcband = ds.GetRasterBand(1);



            Band band = ds.GetRasterBand(1);

            //var elevation = band.


            //print "creating shapefile..."
            string dst_layername = "outFile";
            OSGeo.OGR.Driver drv = Ogr.GetDriverByName("MapInfo file");
            DataSource dst_ds = drv.CreateDataSource(@"C:\Users\rez\Pictures\Saburov\forQuicklooks\outFile.TAB", null);
            //wkbGeometryType geom = new wkbGeometryType();
            OSGeo.OSR.SpatialReference new_sr = new OSGeo.OSR.SpatialReference("");
            Layer dst_layer = dst_ds.CreateLayer(dst_layername, new_sr, OSGeo.OGR.wkbGeometryType.wkbPolygon, null);

            Gdal.Polygonize(srcband, null, dst_layer, -1, null, null, null);
            

            //var options = new GDALRasterizeOptions(new[]
            //{
            //    "-l", $"{dst_layer}",
            //    "-co", "NAME=ESRI Shapefile"
            //});

            //Dataset dd = Gdal.wrapper_GDALRasterizeDestName(@"C: \Users\rez\Pictures\Saburov\forQuicklooks\shape.shp", ds, options, null, null);
        }
    }
}
