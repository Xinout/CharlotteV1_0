using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharlotteV1_0
{
    static class Global
    {
        public static Main mainForm;
        public static DAL.Common common;

        public static int idProvider = 0;
        public static int idItem = 0;
        public static int idTicket = 0;
        public static int idInvoice = 0;
        public static int idInvoiceLine = 0;
        public static int idTicketLine = 0;

        public static bool error = false;
    }
}
