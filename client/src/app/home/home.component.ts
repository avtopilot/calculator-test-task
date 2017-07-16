import { CalculatorService } from '../shared/calculator.service';
import { Calculator } from './calculator';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'my-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  result: Calculator;
  model: {expression: string};

  constructor(
    private calculationService: CalculatorService
  ) {
    // Do stuff
    this.result = new Calculator();
    this.model = {expression: null};
  }

  ngOnInit() {
  }

  onSubmit() {
    if (this.model.expression) {
      this.calculationService.getcCalculationResult(this.model.expression)
        .subscribe((data: Calculator) => this.result = data);
    }
  }

  onShowHistory() {
    console.log('show');
  }

}
