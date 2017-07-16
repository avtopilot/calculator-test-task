import { CalculatorService } from '../shared/calculator.service';
import { Component } from '@angular/core';

import { TestBed } from '@angular/core/testing';

import { HomeComponent } from './home.component';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

describe('Home Component', () => {
  const html = '<my-home></my-home>';

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [HomeComponent, TestComponent],
      imports: [HttpModule, FormsModule],
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
