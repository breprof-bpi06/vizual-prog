namespace Bevezeto
{
    // Érdekes
    // Kiegészíti a kutyát egy ilyen metódussal.
    static class DogExtension
    {
        public static void Barmi(this Dog dog)
        {
            dog.Pet();
        }
    }
}
