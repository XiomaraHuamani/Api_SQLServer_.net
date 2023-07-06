namespace api_servicios_clinica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class doctores
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string apellidos { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string especialidad { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string turno { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string horario { get; set; }
    }
}
