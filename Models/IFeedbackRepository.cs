using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practive_shop.Models
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
