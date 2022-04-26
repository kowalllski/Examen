using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Application
    {
        private Application _application;
        private List<TaskList> _taskLists;
    
        private Application(Application application, List<TaskList> taskLists)
        {
            this._application = application;
            this._taskLists = taskLists;
        }

        public Application GetApplication()
        {
            return this._application;
        }

    }
}
