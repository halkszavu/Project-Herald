import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewPieceFormComponent } from './new-piece-form.component';

describe('NewPieceFormComponent', () => {
  let component: NewPieceFormComponent;
  let fixture: ComponentFixture<NewPieceFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NewPieceFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewPieceFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
