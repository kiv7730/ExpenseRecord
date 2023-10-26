import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExpenseCmntComponent } from './expense-cmnt.component';

describe('ExpenseCmntComponent', () => {
  let component: ExpenseCmntComponent;
  let fixture: ComponentFixture<ExpenseCmntComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExpenseCmntComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExpenseCmntComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
