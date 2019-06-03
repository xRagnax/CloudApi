import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RescourseIdComponent } from './rescourse-id.component';

describe('RescourseIdComponent', () => {
  let component: RescourseIdComponent;
  let fixture: ComponentFixture<RescourseIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RescourseIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RescourseIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
