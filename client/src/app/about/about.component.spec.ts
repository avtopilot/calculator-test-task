import { TestBed } from '@angular/core/testing';

import { AboutComponent } from './about.component';

describe('About Component', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({declarations: [AboutComponent]});
  });

  it('should ...', () => {
    const fixture = TestBed.createComponent(AboutComponent);
    fixture.detectChanges();
    expect(fixture.nativeElement.children[0].textContent).toContain('This is a simple SPA');
    expect(fixture.nativeElement.children[1].children[0].textContent).toContain('Author');
    expect(fixture.nativeElement.children[1].children[1].textContent).toContain('Tolipova');
  });

});
