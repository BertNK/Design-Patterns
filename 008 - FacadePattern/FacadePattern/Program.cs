namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cdPlayer = new CdPlayer(amp);
            DvdPlayer dvdPlayer = new DvdPlayer(amp);
            PopcornPopper popcornPopper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner(amp);

            amp.SetTuner(tuner);
            amp.SetCd(cdPlayer);
            amp.SetDvd(dvdPlayer);

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                amp,
                tuner,
                dvdPlayer,
                cdPlayer,
                projector,
                screen,
                lights,
                popcornPopper);

            homeTheater.WatchMovie("Die Hard");
            homeTheater.EndMovie();
        }
    }
}