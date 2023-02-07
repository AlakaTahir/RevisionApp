using RevisionApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevisionApp.Service
{
    public class DisplayService : IDisplayService
    {
        public DisplayService()
        {

        }

        public string DisplayName(NameCollectorModel model)
        {
            return model.FirstName + " " + model.LastName;
        }
    }
}
