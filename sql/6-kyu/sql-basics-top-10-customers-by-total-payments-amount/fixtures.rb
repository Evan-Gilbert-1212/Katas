# calling run_sql will print the results and return them so that you can test data within them.
# if you want to test different sets of data, then its best to move this code into its own top level describe
# block. If you are only testing one set though, its better to set the results before you enter a describe block
# so that the results are presented at the top of the output.
results = run_sql

describe :query do
  describe :columns do
    it "should return 4 columns" do
      expect(results.first.keys.count).to eq 4
    end
    
    it "should return a customer_id column" do
      expect(results.first.keys).to include(:customer_id)
    end
    
    it "should return a email column" do
      expect(results.first.keys).to include(:email)
      expect(results.first[:email]).to include "@"
    end
    
    it "should return a payments_count column" do
      expect(results.first.keys).to include(:payments_count)
    end
    
    describe "total_amount column" do
      it "should have the column" do
        expect(results.first.keys).to include(:total_amount)
      end
    
      it "should return a float value" do
        expect(results.first[:total_amount]).to be_a Float
      end
    end
  end
  
  describe :rows do
    it "should be ordered by highest total_amount" do
      expect(results.first[:total_amount]).to eq 211.55
    end
    
    it "should return only 10 records" do
      expect(results.count).to eq 10
    end
    
    it "should return expected results" do
      expect(results.to_a).to eq expected
    end
  end
  
  
end