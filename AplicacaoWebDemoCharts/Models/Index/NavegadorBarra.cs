
namespace AplicacaoWebDemoCharts.Models.Index
{
    public class NavegadorBarra
    {
        public NavegadorBarra()
        {

        }
        public object[] ObterNavegadoresParaMontarGraficoBarra()
        {
            object[] data = new object[5];
            data[0] = new object[] { "Edge", 12 };
            data[1] = new object[] { "Firefox", 70 };
            data[2] = new object[] { "Safari", 20 };
            data[3] = new object[] { "Internet Explorer", 20 };
            data[4] = new object[] { "Outros", 30 };

            return data;
        }
    }
}