using System.ComponentModel.DataAnnotations;

namespace RegistroClientes.Data.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Nombre { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(100)]
    public string Apellido { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(20)]
    public string CUIT { get; set; } = string.Empty;
    
    [MaxLength(20)]
    public string? TelefonoFijo { get; set; }
    
    [MaxLength(20)]
    public string? Celular { get; set; }
    
    [MaxLength(100)]
    public string? Mail { get; set; }
    
    [MaxLength(100)]
    public string? Ciudad { get; set; }
    
    [MaxLength(200)]
    public string? Calle { get; set; }
    
    [MaxLength(20)]
    public string? Numero { get; set; }
    
    [MaxLength(10)]
    public string? CodigoPostal { get; set; }
}