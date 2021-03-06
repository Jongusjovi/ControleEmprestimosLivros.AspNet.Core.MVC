// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ControleEmprestimosLivros.AspNet.Core.MVC.DATA.Models
{
    [Table("LIVROS")]
    public partial class Livros
    {
        public Livros()
        {
            Livrosclientes = new HashSet<Livrosclientes>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NOME")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [Column("AUTOR")]
        [StringLength(200)]
        public string Autor { get; set; }
        [Required]
        [Column("EDITORA")]
        [StringLength(100)]
        public string Editora { get; set; }
        [Column("ANOPUBLICACAO", TypeName = "datetime")]
        public DateTime? Anopublicacao { get; set; }
        [Column("EDICAO")]
        [StringLength(50)]
        public string Edicao { get; set; }

        [InverseProperty("Livro")]
        public virtual ICollection<Livrosclientes> Livrosclientes { get; set; }
    }
}