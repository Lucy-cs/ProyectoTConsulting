using System;
using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key] // Indica que es la clave primaria
    public int UsuarioID { get; set; }

    [Required] // Validación: Campo obligatorio
    [MaxLength(100)] // Validación: Longitud máxima de 100 caracteres
    public string NombreUsuario { get; set; }

    [Required]
    [MaxLength(255)]
    public string Contraseña { get; set; }

    [Required]
    [MaxLength(50)]
    public string Rol { get; set; }

    public DateTime FechaCreacion { get; set; } = DateTime.Now; // Valor por defecto

    // Puedes agregar propiedades de navegación si tienes relaciones
    // public virtual ICollection<Permiso> Permisos { get; set; }
}
