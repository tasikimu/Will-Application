import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WillTypesComponent } from './will-types.component';

describe('WillTypesComponent', () => {
  let component: WillTypesComponent;
  let fixture: ComponentFixture<WillTypesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WillTypesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WillTypesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
