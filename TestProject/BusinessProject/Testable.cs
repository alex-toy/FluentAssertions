namespace BusinessLayer
{
    public class Testable
    {
        public void MethotThatThrowsExeption(int threshold)
        {
            if (threshold > 5) throw new ArgumentNullException("error_message");
        }

        public void MethotThatDoesntThrowsExeption()
        {
            
        }
    }
}