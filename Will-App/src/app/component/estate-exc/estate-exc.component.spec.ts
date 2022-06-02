import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EstateExcComponent } from './estate-exc.component';

describe('EstateExcComponent', () => {
  let component: EstateExcComponent;
  let fixture: ComponentFixture<EstateExcComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EstateExcComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EstateExcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
