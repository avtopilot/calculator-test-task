import { NO_ERRORS_SCHEMA } from '@angular/core';
import {
  async,
  TestBed,
  ComponentFixture
} from '@angular/core/testing';
import { AboutComponent } from './about.component';

describe('About component', () => {
  let comp: AboutComponent;
  let fixture: ComponentFixture<AboutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AboutComponent ],
      schemas: [NO_ERRORS_SCHEMA]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutComponent);
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

  it('should have some description', () => {
    expect(fixture.nativeElement.children[0].textContent).toContain('This is a simple SPA');
  });

  it('should have author', () => {
    expect(fixture.nativeElement.children[1].children[0].textContent).toContain('Author');
    expect(fixture.nativeElement.children[1].children[1].textContent).toContain('Tolipova');
  });
});
