import { Calculator } from '../home/calculator';
import { CalculatorService } from '../shared/calculator.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.scss']
})
export class HistoryComponent implements OnInit {
    history: Calculator[];
    isEmpty = () => !this.history || this.history.length === 0;

    constructor(
        private calculationService: CalculatorService
    ) {
    }

    ngOnInit(): void {
        this.calculationService.getHistory()
            .subscribe((data: Calculator[]) => this.history = data);
    }
}
