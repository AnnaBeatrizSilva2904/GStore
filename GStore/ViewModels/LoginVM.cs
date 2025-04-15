using System.ComponentModel.DataAnnotations;
namespace GStore.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou nome de usuário", Prompt = "Informe seu Email ou nome de usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "************")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter conectado?")]
    public bool Lembrar { get; set; }

    public string UrlRetorno { get; set; }        
}
