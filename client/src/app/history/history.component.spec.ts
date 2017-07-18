import { HistoryComponent } from './history.component';
import { CalculatorService } from '../shared/calculator.service';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import {
  async,
  TestBed,
  ComponentFixture
} from '@angular/core/testing';
import {
  BaseRequestOptions,
  ConnectionBackend,
  Http
} from '@angular/http';
import { MockBackend } from '@angular/http/testing';

describe('History component', () => {
  let comp: HistoryComponent;
  let fixture: ComponentFixture<HistoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [HistoryComponent],
      schemas: [NO_ERRORS_SCHEMA],
      providers: [
          CalculatorService,
          BaseRequestOptions,
          MockBackend,
          {
              provide: Http,
              useFactory: (backend: ConnectionBackend, defaultOptions: BaseRequestOptions) => {
                  return new Http(backend, defaultOptions);
              },
              deps: [MockBackend, BaseRequestOptions]
          },
        ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HistoryComponent);
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
    expect(comp.history).toEqual(undefined);
  });
});
