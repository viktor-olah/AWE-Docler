using AWEVideoPlayer.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AWEVideoPlayer.ViewModel.Command
{
    public class SearchCommand : ICommand
    {
        public AWEVM VM { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SearchCommand(AWEVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            string titel = parameter as string;

            if (string.IsNullOrWhiteSpace(titel))
                return false;
            return true;
        }

        public void Execute(object parameter)
        {
            VM.TitelSearch(VM.Titelsearch);
        }
    }
}
