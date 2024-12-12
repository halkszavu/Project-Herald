import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewConcertFormComponent } from './new-concert-form.component';

describe('NewConcertFormComponent', () => {
  let component: NewConcertFormComponent;
  let fixture: ComponentFixture<NewConcertFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewConcertFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewConcertFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
