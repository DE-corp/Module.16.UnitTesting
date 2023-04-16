﻿using NUnit.Framework;

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
            CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            ticketServiceTest.DeleteTicket(newTicket);

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }
    }
}
