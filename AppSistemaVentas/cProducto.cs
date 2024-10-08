public class cProducto
{
    //para poder usar tipos
    public enum TipoProducto
    {
        Bicicleta,
        Coche,
        Moto,
        Scooter
    }

    //Atributos
    private string aCod;
    private string aNombre;
    private string aPrecio;
    private TipoProducto aTipo;

    //Metodos
    //constructores
    public cProducto()
    {
        aCod = "";
        aNombre = "";
        aPrecio = "";
        aTipo = TipoProducto.Bicicleta;
    }

    public cProducto(string pCod, string pNombre, string pPrecio, TipoProducto pTipo)
    {
        aCod = pCod;
        aNombre = pNombre;
        aPrecio = pPrecio;
        aTipo = pTipo; 
    }

    //set y get
    public string getCodigo()
    {
        return aCod;
    }

    public void setCodigo(string pCod)
    {
        aCod = pCod;
    }

    
    public string getNombre()
    {
        return aNombre;
    }

    public void setNombre(string pNombre)
    {
        aNombre = pNombre;
    }

    
    public string getPrecio()
    {
        return aPrecio;
    }

    public void setPrecio(string pPrecio)
    {
        aPrecio = pPrecio;
    }

    
    public TipoProducto getTipo()
    {
        return aTipo;
    }

    public void setTipo(TipoProducto pTipo)
    {
        aTipo = pTipo;
    }

    
    public virtual void mostrar()
    {
        Console.WriteLine("========================");
        Console.WriteLine("INFORMACION DEL PRODUCTO");
        Console.WriteLine("========================");
        Console.WriteLine($"Código : {aCod}");
        Console.WriteLine($"Nombre : {aNombre}");
        Console.WriteLine($"Precio : {aPrecio}");
        Console.WriteLine($"Tipo : {aTipo}");
    }

    public virtual string mostrarTipo()
    {
        return "Producto genérico";
    }
}
