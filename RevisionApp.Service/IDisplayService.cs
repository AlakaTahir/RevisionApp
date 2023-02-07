using RevisionApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevisionApp.Service
{
    public interface IDisplayService
    {
        string DisplayName(NameCollectorModel model);
    }
}
