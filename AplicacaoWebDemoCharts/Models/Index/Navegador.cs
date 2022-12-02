
using System.Collections.Generic;

namespace AplicacaoWebDemoCharts.Models.Index
{
    public class Navegador
    {
        public Navegador()
        {

        }
        public string name { get; set; }
        public double y { get; set; }
        public bool fatiado { get; set; }
        public bool selecionado { get; set; }

        public Navegador(string name, double y, bool fatiado = false, bool selecionado = false)
        {
            this.name = name;
            this.y = y;
            this.fatiado = fatiado;
            this.selecionado = selecionado;
        }
        public List<Navegador> ObterTodos()
        {
            List<Navegador> lista = new List<Navegador>
            {
                new Navegador("Chrome", 74),
                new Navegador("Edge", 12),
                new Navegador("Firefox", 70),
                new Navegador("Safari", 20),
                new Navegador("Internet Explorer", 20),
                new Navegador("Outros", 30)
            };

            return lista;
        }
    }
}
