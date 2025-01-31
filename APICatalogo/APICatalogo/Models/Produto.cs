﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;


[Table("Produtos")]
public class Produto
{
    [Key]
    public Guid ProdutoId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Required]
    [Column(TypeName ="Decimal(10,2)")]
    public int Preco { get; set; }

    [Required]
    [StringLength(300)]
    public int? ImagemUrl { get; set; }
    public float Estoque { get; set; }

    public DateTime DataCadastro { get; set; }
    
    public int CategoriaId { get; set; }

    public Categoria? Categoria { get; set; }
}
