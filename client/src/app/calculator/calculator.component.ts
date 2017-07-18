import { CalculatorService } from '../shared/calculator.service';
import { Calculator } from './calculator';
import { Component } from '@angular/core';

@Component({
  selector: 'calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.scss']
})
export class CalculatorComponent {
  result: Calculator;
  model: {expression: string};

  constructor(
    private calculationService: CalculatorService
  ) {
    this.result = this.clearResult();
    this.model = {expression: null};
  }

  private clearResult = () => this.result = new Calculator();

  onSubmit() {
    if (this.model.expression) {
      this.calculationService.getcCalculationResult(this.model.expression)
        .subscribe((data: Calculator) => this.result = data);
    }
  }

  onExpressionChange() {
    this.clearResult();
  }
}
