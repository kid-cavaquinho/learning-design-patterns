namespace Behavioral.Template_Method
{
    public abstract class AbstractGuitar
    {
        public void TemplateMethod()
        {
            Tune();
            Play();
        }

        public abstract void Tune();

        public abstract void Play();
    }
}
