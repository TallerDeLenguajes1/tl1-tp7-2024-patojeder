namespace EspacioCalculadora;

public class Calculadora{
private double Dato=256;

public double Resultado { get => Dato;}

public void Sumar(double termino){
    Dato += termino;
}
public void Restar(double termino){
    Dato -= termino;
}
public void Multiplicar(double termino){
    Dato= Dato * termino;
}
public void Dividir(double termino){
    Dato= Dato/termino;
}
public void Limpiar(){
    Dato= 0;
}

}