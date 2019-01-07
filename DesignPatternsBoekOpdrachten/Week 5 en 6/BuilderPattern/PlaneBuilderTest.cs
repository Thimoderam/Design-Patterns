using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBoekOpdrachten.Week_5_en_6.BuilderPattern
{
    public class PlaneBuilderTest
    {
        private PlaneBuilder builder;
        public PlaneBuilderTest()
        {
            PlaneDirector director = new PlaneDirector();
            builder = new Cessna172Builder("PH-CESSNA");
            director.Construct(builder);
            builder.Plane.ShowInfo();
            builder = new AirbusA380Builder("PH-AIRB");
            director.Construct(builder);
            builder.Plane.ShowInfo();
        }
    }
}
