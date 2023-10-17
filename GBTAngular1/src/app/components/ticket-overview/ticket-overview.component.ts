import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-ticket-overview',
  templateUrl: './ticket-overview.component.html',
  styleUrls: ['./ticket-overview.component.css']
})
export class TicketOverviewComponent implements OnInit {
  tickets: any[] = [];

  constructor(private ticketService: ApiService) {}

  ngOnInit(): void {
    this.getTickets();
  }

  getTickets(): void {
    const userId = 1; 
    this.ticketService.getTicketsByUserId(userId).subscribe(
      (tickets) => {
        this.tickets = tickets;
      },
      (error) => {
        console.error('Error fetching tickets:', error);
      }
    );
  }
}
