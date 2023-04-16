using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Module._16.UnitTesting.Tests
{
    [TestFixture]
    class TicketServiceIntegrationTests
    {
        [Test]
        public void SaveTicketMustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.SaveTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            NUnit.Framework.CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            PrivateObject obj = new PrivateObject(ticketServiceTest);
            obj.Invoke("DeleteTicket", newTicket);

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            NUnit.Framework.CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }
    }
}
