namespace EspacioEmpleado;


enum Cargos{
   auxiliar=0,
    administrativo=1,
    ingeniero=2,
    especialista=3,
    investigador=4,

}
public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private string estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private Cargos cargo;
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    internal Cargos Cargo { get => cargo; set => cargo = value; }
}
