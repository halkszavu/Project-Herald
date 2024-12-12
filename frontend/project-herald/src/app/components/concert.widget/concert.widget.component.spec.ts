import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConcertWidgetComponent } from './concert.widget.component';

describe('ConcertWidgetComponent', () => {
  let component: ConcertWidgetComponent;
  let fixture: ComponentFixture<ConcertWidgetComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConcertWidgetComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConcertWidgetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
