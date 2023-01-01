using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFC___StandBy_CSharp.Models
{
    public class ChecklistEstrutura
    {
        public int? ID { get; set; } = null;
        public int? OrdemServico { get; set; } = null;
        public DateTime? DataChecklist { get; set; } = null;
        public int? FK_IdServico { get; set; } = null;
        public string BiometriaFaceID { get; set; } = null;
        public string Microfone { get; set; } = null;
        public string Tela { get; set; } = null;
        public string Chip { get; set; } = null;
        public string Botoes { get; set; } = null;
        public string Sensor { get; set; } = null;
        public string Cameras { get; set; } = null;
        public string Auricular { get; set; } = null;
        public string Wifi { get; set; } = null;
        public string AltoFalante { get; set; } = null;
        public string Bluetooth { get; set; } = null;
        public string Carregamento { get; set; } = null;
        public string Observacoes { get; set; } = null;
        public bool Ausente { get; set; }
        public string MotivoAusencia { get; set; } = null;
    }
}