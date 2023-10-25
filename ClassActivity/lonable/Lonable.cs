public class Lonable
{
    protected bool _isCheckedIn = true;

    public void CheckOut()
    {
        _isCheckedIn = false;
    }

    public void CheckIn()
    {
        _isCheckedIn = true;
    }

    public virtual void Display()
    {
        
    }
}