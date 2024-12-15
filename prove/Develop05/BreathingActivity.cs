using System.ComponentModel.DataAnnotations;

class BreathingActivity:Activity {
    public BreathingActivity():base("Breathing Activity", "Breathe in and out to relax.") {}

    public void Perform() {
        Start();
        for (int i = 0; i < _length / 6; i++) {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Breathe out...");
            Thread.Sleep(5000);
        }
        Console.Clear();
        End();
    }
}