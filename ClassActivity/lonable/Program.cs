public class SomeClass
{
    private Dvd myDvd;

    public SomeClass()
    {
        myDvd = new Dvd("Hulk");
    }

    public void CheckOutDvd()
    {
        myDvd.CheckOut();
    }

    public void DoSomethingWithDvd()
    {
        // You can work with myDvd here.
    }
}
