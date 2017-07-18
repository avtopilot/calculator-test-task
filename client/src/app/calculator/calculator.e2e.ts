import { browser, by, element } from 'protractor';
import 'tslib';

describe('Calculator', function () {

  beforeEach(function () {
    browser.get('/');
  });

  it('should have <calculator>', async () => {
    let subject = await element(by.css('app calculator')).isPresent();
    let result  = true;
    expect(subject).toEqual(result);
  });

});
