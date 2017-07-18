import { Calculator } from './calculator';
import { RouterTestingModule } from '@angular/router/testing';
import { CalculatorService } from '../shared/calculator.service';
import { CalculatorComponent } from './calculator.component';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import {
  async,
  TestBed,
  ComponentFixture
} from '@angular/core/testing';

describe('Calculator component', () => {
  let comp: CalculatorComponent;
  let fixture: ComponentFixture<CalculatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CalculatorComponent ],
      schemas: [NO_ERRORS_SCHEMA],
      imports: [HttpModule, FormsModule, RouterTestingModule],
      providers: [CalculatorService]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CalculatorComponent);
    comp = fixture.componentInstance;

    /**
     * Trigger initial data binding
     */
    fixture.detectChanges();
  });

  it('should be readly initialized', () => {
    expect(fixture).toBeDefined();
    expect(comp).toBeDefined();
  });

  it('should be @AngularClass', () => {
    expect(comp.result).toEqual(new Calculator());
    expect(comp.model).toEqual({expression: null});
  });

  it('should have an input', () => {
    expect(fixture.nativeElement.querySelector('input')).toBeDefined();
  });

  it('should have a calculate button', () => {
    expect(fixture.nativeElement.querySelector('button').textContent).toContain('Calculate');
  });

});
