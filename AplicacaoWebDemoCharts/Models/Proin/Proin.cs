using System;
using System.Collections.Generic;

namespace AplicacaoWebDemoCharts.Models.Proin
{
    public class Proin
    {
        public Proin()
        {

        }
        public string name { get; set; }
        public string adesaoDesignacao { get; set; }
        public string elaboracaoValidacao { get; set; }
        public string gestaoRiscos { get; set; }
        public string monitoramento { get; set; }
        public int y { get; set; }
        public DateTime dataAdesao { get; set; }
        public DateTime dataRegistro { get; set; }

        public Proin(string secretaria, string adesaoDesignacao, string elaboracaoValidacao, string gestaoRiscos, string monitoramento, int porcentagem, DateTime dataAdesao, DateTime dataRegistro)
        {
            this.name = secretaria;
            this.adesaoDesignacao = adesaoDesignacao;
            this.elaboracaoValidacao = elaboracaoValidacao;
            this.gestaoRiscos = gestaoRiscos;
            this.monitoramento = monitoramento;
            this.y = porcentagem;
            this.dataAdesao = dataAdesao;
            this.dataRegistro = dataRegistro;
        }

        public List<Proin> ObterTodos()
        {
            List<Proin> lista = new List<Proin>
            {
                new Proin("CGE", "Designação de equipe", "Planejamento das ações estratégicas", "Proposta de tratamento de riscos", null, 75, DateTime.Now, DateTime.Now),
                new Proin("SEFIN", "Designação de equipe", "Levantamento do cenário atual", "Identificação e priorização dos riscos", null, 75, DateTime.Now, DateTime.Now),
                new Proin("SESAU", "Adesão ao proin", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("SUPEL", "Adesão ao proin", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("DER", "Designação de equipe", null, null, null, 50, DateTime.Now, DateTime.Now),
                new Proin("POLITEC", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("JUSCER", "Designação de equipe", null, null, null, 75, DateTime.Now, DateTime.Now),
                new Proin("SEOSP", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("IPERON", "Designação de equipe", null, null, null, 50, DateTime.Now, DateTime.Now),
                new Proin("SEPOG", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("SUGESP", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("SESDEC", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("SEJUCEL", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("SEDEC", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("SETIC", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
                new Proin("DETRAN", "Designação de equipe", null, null, null, 25, DateTime.Now, DateTime.Now),
            };
            return lista;
        }
    }
}
