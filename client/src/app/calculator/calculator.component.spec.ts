import { RouterTestingModule } from '@angular/router/testing';
import { CalculatorService } from '../shared/calculator.service';
import { Component } from '@angular/core';
import { TestBed } from '@angular/core/testing';
import { CalculatorComponent } from './calculator.component';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

describe('Calculator Component', () => {
  const html = '<calculator></calculator>';

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CalculatorComponent, TestComponent],
      imports: [HttpModule, FormsModule, RouterTestingModule],
      providers: [CalculatorService]
    });
    TestBed.overrideComponent(TestComponent, { set: { template: html }});
  });

  it('should ...', () => {
    const fixture = TestBed.createComponent(TestComponent);
    fixture.detectChanges();
    expect(fixture.nativeElement.querySelector('input')).toBeDefined();
    expect(fixture.nativeElement.querySelector('button').textContent).toContain('Calculate');
  });

});

@Component({selector: 'my-test', template: ''})
class TestComponent { }
