import { CalculatorService } from '../shared/calculator.service';
import { Calculator } from './calculator';
import { Component } from '@angular/core';

@Component({
  selector: 'my-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  result: Calculator;
  model: {expression: string};

  constructor(
    private calculationService: CalculatorService
  ) {
    this.result = new Calculator();
    this.model = {expression: null};
  }

  onSubmit() {
    if (this.model.expression) {
      this.calculationService.getcCalculationResult(this.model.expression)
        .subscribe((data: Calculator) => this.result = data);
    }
  }
}
