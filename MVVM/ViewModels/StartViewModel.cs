using MVVM.Models;

namespace MVVM.ViewModels
{
    public class StartViewModel
    {
        public Pearson Pearson { get; set; }

        public StartViewModel()
        {
            Pearson = new Pearson();
        }
    }
}
